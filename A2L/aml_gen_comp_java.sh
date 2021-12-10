#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf a2mljava
antlr4 -Dlanguage=Java -o a2mljava -long-messages -listener -visitor -package a2mljava AML.g4
javac -cp ./antlr-4.9.3-complete.jar a2mljava/AML*.java
java org.antlr.v4.gui.TestRig a2mljava.AML a2ml -gui A2ML_Demo_V171.aml

