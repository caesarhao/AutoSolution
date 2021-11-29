#!/usr/bin/env bash
rm -rf _genPy3
antlr4 -Dlanguage=Python3 -o _genPy3 -long-messages -listener -visitor -package a2ltool A2L.g4

