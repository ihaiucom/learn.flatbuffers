#!/bin/bash

for i in *.fbs;
do
	./flatbuffers/flatc --csharp --gen-mutable -o `pwd`/../Example/Example/Proto $i ;
done


