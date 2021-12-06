#!/usr/bin/env bash
currentPath=`pwd`
export CLASSPATH=".:$currentPath/antlr-4.9.3-complete.jar:$CLASSPATH"
#alias antlr4='java -jar antlr-4.9.3-complete.jar'
alias grun='java org.antlr.v4.gui.TestRig'

rm -rf _genPy3
antlr4 -Dlanguage=Python3 -o _genPy3 -long-messages -listener -visitor -package a2ltool A2L.g4

