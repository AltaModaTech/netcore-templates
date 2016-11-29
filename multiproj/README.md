# Multiproj
A template for multiple .NET Core modules with tests.

Module1 and Module2 are very basic and similar.  Each declares a simple class
and a companion factory.  Module1's class and factory require a name parameter
making them marginally more sophisticated.

Test.Shared is another module, yet for testing purposes.  This module provides
a location for data, operations, etc. to avoid duplication.  The TestData class
provides a simple list of names.

Test.Modules exposes xUnit tests for Module1 & Module2.  Test.Modules contains tests
for both of the product modules because the test task (in .vscode/tasks.json) only supports a single test module. Unlike the build
task, which iterates over the args array, the test task passes all args to a 
single command.