#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf a2mlcsharp
antlr4 -Dlanguage=CSharp -o a2mlcsharp -long-messages -listener -visitor -package a2mlcsharp AML.g4


