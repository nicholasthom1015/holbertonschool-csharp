#!/usr/bin/env bash

mkdir 0-new_project
cd 0-new_project
dotnet new console
dotnet build
dotnet run 1 2 3