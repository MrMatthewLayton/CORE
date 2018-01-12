# Cryptography

The `Core.Security.Cryptography` namespace provides cryptographic services, such as hashing.

**Namespace:** Core.Security.Cryptography

**Assembly:** Core (Core.dll)

| Type Name        | Type  | Description                              |
| ---------------- | ----- | ---------------------------------------- |
| [Hash]()         | Class | Represents a hash.                       |
| Keccak224Managed | Class | Computes the SHA3 Keccak 224 hash for the input data using the managed library. |
| Keccak256Managed | Class | Computes the SHA3 Keccak 256hash for the input data using the managed library. |
| Keccak384Managed | Class | Computes the SHA3 Keccak 384 hash for the input data using the managed library. |
| Keccak512Managed | Class | Computes the SHA3 Keccak 512 hash for the input data using the managed library. |
| SHA3             | Class | Computes the SHA3 hash for the input data. |
| Shake128Managed  | Class | Computes the SHA3 Shake 128 hash for the input data using the managed library. |
| Shake256Managed  | Class | Computes the SHA3 Shake 256 hash for the input data using the managed library. |

## Hash (class)

The `Hash` class provides a semantic representation of a hash.

### Members

| Signature             | Type            | Description                              |
| --------------------- | --------------- | ---------------------------------------- |
| `==(Hash a, Hash b)`  | operator        | Performs an equality check between two object instances. |
| `!=(Hash a, Hash b)`  | operator        | Performs an inequality check between two object instances. |
| `FromBytes(byte[])`   | static method   | Creates a `Hash` instance from a byte array. |
| `Parse(string value)` | static method   | Converts the string representation of a hash to its `Hash` equivalent. |
| `Equals(Hash other)`  | instance method | Checks for equality between this instance and another object. |
| `Equals(object obj)`  | instance method | Checks for equality between this instance and another object. |
| `GetHashCode()`       | instance method | Serves as a hash code function for this instance. |
| `ToString()`          | instance method | Returns a `string` that represents the current object. |
| `ToByteArray()`       | instance method | Returns a byte array representing this instance. |

### Example

```c#
using(SHA256 hashAlgorithm = SHA256.Create())
{
    Hash hash = Hash.FromBytes(hashAlgorithm.ComputeHash(...));
}
```