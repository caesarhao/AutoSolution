#!/usr/bin/env bash
rm -rf _genJava
antlr4 -Dlanguage=Java -o _genJava -long-messages -listener -visitor -package a2ltool A2L.g4
javac -cp ./antlr-4.9.3-complete.jar _genJava/A2L*.java

