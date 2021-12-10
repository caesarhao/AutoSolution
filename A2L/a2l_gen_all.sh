#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf a2ljava
antlr4 -Dlanguage=Java -o a2ljava -long-messages -listener -visitor -package a2ljava A2L.g4

rm -rf a2lpy3
antlr4 -Dlanguage=Python3 -o a2lpy3 -long-messages -listener -visitor -package a2lpy3 A2L.g4

rm -rf a2lcsharp
antlr4 -Dlanguage=CSharp -o a2lcsharp -long-messages -listener -visitor -package a2lcsharp A2L.g4
