# Specflow To Reqnroll Migration Demo

This repository contains the code examples and resources for migrating Behavior-Driven Development (BDD) tests from SpecFlow to Reqnroll. The migration process is essential due to SpecFlow's discontinuation of support for .NET 8. Reqnroll, based on the open-source code of SpecFlow, ensures compatibility and functionality with modern .NET versions.

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Migration Steps](#migration-steps)
  - [Step 1: Setup Reqnroll](#step-1-setup-reqnroll)
  - [Step 2: Migrating Feature Files](#step-2-migrating-feature-files)
  - [Step 3: Updating Bindings](#step-3-updating-bindings)
  - [Step 4: Configuring Test Execution](#step-4-configuring-test-execution)
- [Examples](#examples)
- [Resources](#resources)
- [Contributing](#contributing)
- [License](#license)

## Introduction
This repository serves as a companion to the article "SpecFlow to Reqnroll: Step-by-Step Guide to Migrating BDD Tests." It provides code examples for feature files, bindings, and test configurations that have been migrated from SpecFlow to Reqnroll. The goal is to maintain robust and future-proof BDD test automation within the .NET ecosystem.

## Prerequisites
- .NET 7 or .NET 8 SDK installed on your development environment.
- Familiarity with SpecFlow and basic understanding of Reqnroll.
- Visual Studio or another .NET-compatible IDE.

## Getting Started
1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/Reqnroll-Migration-Demo.git
    cd Reqnroll-Migration-Demo
    ```

2. **Install dependencies:**
    Ensure that you have all the required NuGet packages installed for Reqnroll.

3. **Run the tests:**
    Use your IDE or command line to run the BDD tests and see how the migration has been applied.

## Migration Steps

### Step 1: Setup Reqnroll
- Install the Reqnroll NuGet package and configure it within your .NET project.

### Step 2: Migrating Feature Files
- Move your existing SpecFlow feature files to Reqnroll, making necessary adjustments to syntax and formatting.

### Step 3: Updating Bindings
- Update the namespaces and class bindings from SpecFlow to Reqnroll, ensuring that `ScenarioContext` and `FeatureContext` are correctly mapped.

### Step 4: Configuring Test Execution
- Configure test discovery and execution using MSTest.TestAdapter and Microsoft.NET.Test.Sdk to ensure compatibility with Reqnroll.

## Examples
The repository contains example feature files and test bindings that have been migrated from SpecFlow to Reqnroll:
- `FeatureFiles/ExampleFeature.feature`
- `Bindings/ExampleBinding.cs`
- `TestConfigurations/reqnroll.config`

## Resources
- [Reqnroll Documentation](#) (Link to Reqnroll documentation)
- [SpecFlow Documentation](https://docs.specflow.org/)
- [Article: SpecFlow to Reqnroll Migration](#) (Link to the article)

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue to improve this repository.

## License
This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

This README provides an overview of the repository, instructions for setting up and running the code, and details on how to contribute. Adjust the links and sections as needed to fit your specific project.
