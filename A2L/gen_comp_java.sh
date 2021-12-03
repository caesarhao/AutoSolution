#!/usr/bin/env bash
rm -rf a2ljava
antlr4 -Dlanguage=Java -o a2ljava -long-messages -listener -visitor -package a2ljava A2L.g4
javac -cp ./antlr-4.9.3-complete.jar a2ljava/A2L*.java

