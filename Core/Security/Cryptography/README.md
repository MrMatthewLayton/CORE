# Cryptography

The `Core.Security.Cryptography` namespace provides cryptographic services, such as hashing.

| Key           | Value                      |
| ------------- | -------------------------- |
| **Namespace** | Core.Security.Cryptography |
| **Assembly**  | Core (Core.dll)            |

## Hash (class)

The `Hash` class provides a semantic representation of a hash.

### Operators

| Operator             | Description                              |
| -------------------- | ---------------------------------------- |
| `==(Hash a, Hash b)` | Performs an equality check between two object instances. |
| `!=(Hash a, Hash b)` | Performs an inequality check between two object instances. |

### Static Methods

| Method                | Description                              |
| --------------------- | ---------------------------------------- |
| `FromBytes(byte[])`   | Creates a `Hash` instance from a byte array. |
| `Parse(string value)` | Converts the string representation of a hash to its `Hash` equivalent. |

### Instance Methods

| Method               | Description                              |
| -------------------- | ---------------------------------------- |
| `Equals(Hash other)` | Checks for equality between this instance and another object. |
| `Equals(object obj)` | Checks for equality between this instance and another object. |
| `GetHashCode()`      | Serves as a hash code function for this instance. |
| `ToString()`         | Returns a `string` that represents the current object. |
| `ToByteArray()`      | Returns a byte array representing this instance. |

### Example

```c#
using(SHA256 hashAlgorithm = SHA256.Create())
{
    Hash hash = Hash.FromBytes(hashAlgorithm.ComputeHash(...));
}
```

