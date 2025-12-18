# IC11: Compiler for Stationeers Game IC10 Assembly

A tool that translates (compiles) a high-level language program to an IC10 assembly for the Stationeers game.

The language features a C-like syntax and supports basic instructions, including if/then/else, while loops, function calls, and return values.

Use the [Wiki](https://github.com/Raibo/ic11/wiki) for the ic11 language reference.

# Usage

`ic11 <path> [-w]`  
Provide a path to the source code as a first argument.  
If the path is a file, then this file will be compiled.  
If the path is a directory, then all `*.ic11` files in this directory will be compiled.  
The optional second argument `-w` will write compiled code to new `*.ic10` files next to the sources.

```bash
ic11 source.ic11
ic11 ./examples
ic11 source.ic11 -w
ic11 ./examples -w
```

The compiled code is provided in the Stdout.

# Building

Build binaries:

```bash
task build
```
