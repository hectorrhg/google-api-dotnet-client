#!/bin/bash

CODE_GENERATION_DIR="$1"

# docfx fails completely (throws an exception) with the
# triple-backticks in Dialogflow. The Discovery Doc comments
# aren't formatted anyway, making Markdown basically broken.
# (That needs investigating separately.)
sed -i 's/```//g' "$CODE_GENERATION_DIR"/Google.Apis.Dialogflow.v2beta1/Google.Apis.Dialogflow.v2beta1.cs
