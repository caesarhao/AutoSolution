#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf a2ljava
antlr4 -Dlanguage=Java -o a2ljava -long-messages -listener -visitor -package a2ljava A2L.g4
javac -cp ./antlr-4.9.3-complete.jar a2ljava/A2L*.java
grun a2ljava.A2L a2l -gui ASAP2_Example.a2l

