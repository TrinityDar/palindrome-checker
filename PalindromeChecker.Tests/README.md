# Palindrome Checker

A C# implementation of a palindrome checker, designed with SOLID principles in mind.

## Project Structure

- **PalindromeChecker.Core** — core logic and abstractions
- **PalindromeChecker.Tests** — xUnit test suite covering all cases

## Approach

The solution is built around a simple abstraction — `IStringNormaliser` — which is responsible for cleaning the input string before the palindrome check is performed.

This design allows:
- The `PalindromeService` to remain focused solely on palindrome logic (**Single Responsibility Principle (SRP)**)
- New normalisation strategies to be added without modifying existing code (**Open/Closed Principle (OCP)**)
- The `PalindromeService` to depend on an abstraction, not a concrete implementation (**Dependency Inversion Principle (DIP)**)

## Normalisation

The `AlphaNumericNormaliser` implementation:
- Converts input to lowercase
- Strips spaces and non-letter characters

This allows phrases like `"Mr owl ate my metal worm"` and `"Never Odd Or Even"` to be correctly identified as palindromes.

## Test Cases

| Input | Expected |
|---|---|
| `"abcba"` | `true` |
| `"abcde"` | `false` |
| `"Mr owl ate my metal worm"` | `true` |
| `"Never Odd Or Even"` | `true` |
| `"Never Even Or Odd"` | `false` |

## Running the Tests

```bash
dotnet test
```