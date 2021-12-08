#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf a2mljava
antlr4 -Dlanguage=Java -o a2mljava -long-messages -listener -visitor -package a2mljava AML.g4
rm -rf a2mlpy3
antlr4 -Dlanguage=Python3 -o a2mlpy3 -long-messages -listener -visitor -package a2mlpy3 AML.g4
rm -rf a2mlcsharp
antlr4 -Dlanguage=CSharp -o a2mlcsharp -long-messages -listener -visitor -package a2mlcsharp AML.g4

