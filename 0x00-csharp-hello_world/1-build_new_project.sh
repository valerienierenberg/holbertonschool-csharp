#!/usr/bin/env bash
# Bash script that initializes  and builds a new C# project inside a folder titled 1-new_project.
dotnet new console -o 1-new_project
dotnet build 1-new_project
