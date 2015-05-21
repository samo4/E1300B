# E1300B
An old piece of HP electrical instrumentation is still usable today. Just plug in the serial cable and you can talk to the unit. This is just a rudimentary .NET C# winforms application that makes the VXI mainframe usable again. 


##### ATTENTION: only available to brave coders, this was just a proof of concept and it is forgotten now. Hope it is usefull to somebody.

Some work was done to support the following plugins:

- E1326B (5 1/2 digit multimeter)
- E1340E (arbitrary waveform generator; never managed to upload arbitrary waveform trough serial port. It seems that this is only possible trough GPIB. But works for built-in waveforms.)
- leftover project to connect to Rigol DS2000


### Folders "manuals" and "DSCPI" are just clones of HP publically availible files. They are covered by separate license (not mine). Stored here just for reference.