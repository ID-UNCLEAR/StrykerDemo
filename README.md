# StrykerDemo

## Prerequisites

Ensure that the [.NET SDK](https://dotnet.microsoft.com/en-us/download) is installed on your system before proceeding.

## Running Stryker

To run mutation testing and view the output automatically, first restore the required .NET local tools from the root of the repository:

```bash
~/StrykerDemo$ dotnet tool restore
```

Then, navigate to the unit test project directory to run Stryker and open the HTML report:

```bash
~/StrykerDemo$ cd Library.UnitTests
~/StrykerDemo/Library.UnitTests$ dotnet stryker -o
```
