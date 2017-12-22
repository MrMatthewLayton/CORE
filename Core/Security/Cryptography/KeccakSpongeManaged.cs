namespace Core.Security.Cryptography
{
    using System;
    using System.Runtime.CompilerServices;

    internal sealed class KeccakSpongeManaged
    {
        public const int KeccakDelimiter = 0x06;
        public const int ShakeDelimiter = 0x1f;

        private const int KeccakRounds = 24;

        private readonly ulong[] IotaRoundConstants = new ulong[]
        {
            0x0000000000000001, 0x0000000000008082, 0x800000000000808A, 0x8000000080008000,
            0x000000000000808B, 0x0000000080000001, 0x8000000080008081, 0x8000000000008009,
            0x000000000000008A, 0x0000000000000088, 0x0000000080008009, 0x000000008000000A,
            0x000000008000808B, 0x800000000000008B, 0x8000000000008089, 0x8000000000008003,
            0x8000000000008002, 0x8000000000000080, 0x000000000000800A, 0x800000008000000A,
            0x8000000080008081, 0x8000000000008080, 0x0000000080000001, 0x8000000080008008
        };

        private readonly int rateBytes;
        private readonly int capacityBytes;
        private readonly int delimiter;
        private readonly int outputLength;

        private int blockSize;
        private int inputPointer;
        private int outputPointer;
        private ulong[] state;
        private byte[] result;

        public KeccakSpongeManaged(int rateBytes, int capacityBytes, int delimiter, int outputLength)
        {
            this.rateBytes = rateBytes;
            this.capacityBytes = capacityBytes;
            this.delimiter = delimiter;
            this.outputLength = outputLength;
        }

        public void Initialize()
        {
            blockSize = default;
            inputPointer = default;
            outputPointer = default;
            state = new ulong[25];
            result = new byte[outputLength];
        }

        public void Absorb(byte[] array, int start, int size)
        {
            ulong[] temp = new ulong[rateBytes / sizeof(ulong)];

            while (size > 0)
            {
                blockSize = Math.Min(size, rateBytes);

                for (int i = start; i < blockSize; i++)
                {
                    byte x = Convert.ToByte(Buffer.GetByte(state, i) ^ array[i + inputPointer]);
                    Buffer.SetByte(state, i, x);
                }

                inputPointer += blockSize;
                size -= blockSize;

                if (blockSize == rateBytes)
                {
                    Permute(state);
                    blockSize = 0;
                }
            }
        }

        public byte[] Squeeze()
        {
            byte pad = Convert.ToByte(Buffer.GetByte(state, blockSize) ^ delimiter);
            Buffer.SetByte(state, blockSize, pad);

            if (((delimiter & 0x80) != 0) && blockSize == (rateBytes - 1))
            {
                Permute(state);
            }

            pad = Convert.ToByte(Buffer.GetByte(state, rateBytes - 1) ^ 0x80);
            Buffer.SetByte(state, rateBytes - 1, pad);
            Permute(state);

            int outputBytesLeft = outputLength;

            while (outputBytesLeft > 0)
            {
                blockSize = Math.Min(outputBytesLeft, rateBytes);
                Buffer.BlockCopy(state, 0, result, outputPointer, blockSize);
                outputPointer += blockSize;
                outputBytesLeft -= blockSize;

                if (outputBytesLeft > 0)
                {
                    Permute(state);
                }
            }

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Permute(ulong[] state)
        {
            ulong C0, C1, C2, C3, C4, D0, D1, D2, D3, D4;

            for (int round = 0; round < KeccakRounds; round++)
            {
                Theta();
                RhoPi();
                Chi();
                Iota(round);
            }

            void Theta()
            {
                C0 = state[0] ^ state[5] ^ state[10] ^ state[15] ^ state[20];
                C1 = state[1] ^ state[6] ^ state[11] ^ state[16] ^ state[21];
                C2 = state[2] ^ state[7] ^ state[12] ^ state[17] ^ state[22];
                C3 = state[3] ^ state[8] ^ state[13] ^ state[18] ^ state[23];
                C4 = state[4] ^ state[9] ^ state[14] ^ state[19] ^ state[24];

                D0 = Rotl64(C1, 1) ^ C4;
                D1 = Rotl64(C2, 1) ^ C0;
                D2 = Rotl64(C3, 1) ^ C1;
                D3 = Rotl64(C4, 1) ^ C2;
                D4 = Rotl64(C0, 1) ^ C3;

                state[00] ^= D0;
                state[05] ^= D0;
                state[10] ^= D0;
                state[15] ^= D0;
                state[20] ^= D0;
                state[01] ^= D1;
                state[06] ^= D1;
                state[11] ^= D1;
                state[16] ^= D1;
                state[21] ^= D1;
                state[02] ^= D2;
                state[07] ^= D2;
                state[12] ^= D2;
                state[17] ^= D2;
                state[22] ^= D2;
                state[03] ^= D3;
                state[08] ^= D3;
                state[13] ^= D3;
                state[18] ^= D3;
                state[23] ^= D3;
                state[04] ^= D4;
                state[09] ^= D4;
                state[14] ^= D4;
                state[19] ^= D4;
                state[24] ^= D4;
            }

            void RhoPi()
            {
                ulong A = Rotl64(state[1], 1);

                state[01] = Rotl64(state[06], 44);
                state[06] = Rotl64(state[09], 20);
                state[09] = Rotl64(state[22], 61);
                state[22] = Rotl64(state[14], 39);
                state[14] = Rotl64(state[20], 18);
                state[20] = Rotl64(state[02], 62);
                state[02] = Rotl64(state[12], 43);
                state[12] = Rotl64(state[13], 25);
                state[13] = Rotl64(state[19], 08);
                state[19] = Rotl64(state[23], 56);
                state[23] = Rotl64(state[15], 41);
                state[15] = Rotl64(state[04], 27);
                state[04] = Rotl64(state[24], 14);
                state[24] = Rotl64(state[21], 02);
                state[21] = Rotl64(state[08], 55);
                state[08] = Rotl64(state[16], 45);
                state[16] = Rotl64(state[05], 36);
                state[05] = Rotl64(state[03], 28);
                state[03] = Rotl64(state[18], 21);
                state[18] = Rotl64(state[17], 15);
                state[17] = Rotl64(state[11], 10);
                state[11] = Rotl64(state[07], 06);
                state[07] = Rotl64(state[10], 03);
                state[10] = A;
            }

            void Chi()
            {
                for (int i = 0; i < 25; i += 5)
                {
                    C0 = state[0 + i] ^ ((~state[1 + i]) & state[2 + i]);
                    C1 = state[1 + i] ^ ((~state[2 + i]) & state[3 + i]);
                    C2 = state[2 + i] ^ ((~state[3 + i]) & state[4 + i]);
                    C3 = state[3 + i] ^ ((~state[4 + i]) & state[0 + i]);
                    C4 = state[4 + i] ^ ((~state[0 + i]) & state[1 + i]);

                    state[0 + i] = C0;
                    state[1 + i] = C1;
                    state[2 + i] = C2;
                    state[3 + i] = C3;
                    state[4 + i] = C4;
                }
            }

            void Iota(int round)
            {
                state[0] ^= IotaRoundConstants[round];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ulong Rotl64(ulong x, byte y) => (x << y) | (x >> (64 - y));
    }
}
