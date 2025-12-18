# Setup

```sh
pip install antlr4-tools
```

# Debug GUI

```sh
cd grammars # this dir
antlr4-parse Ic11.g4 program -gui ../examples/old/test.ic11
```

# Generate

```sh
cd grammars # this dir
antlr4 -o ../src/ic11/generated -visitor Ic11.g4
```
