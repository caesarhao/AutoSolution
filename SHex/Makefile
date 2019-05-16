#change this to the name of the Main class file, without file extension
MAIN_FILE = bin/Debug/SHex

#change this to the depth of the project folders
#if needed, add a preffix for a common project folder
CSHARP_SOURCE_FILES = $(wildcard */*/*.cs */*.cs *.cs)

#add needed flags to the compilerCSHARP_FLAGS = -out:$(EXECUTABLE)
CSHARP_FLAGS = -out:$(EXECUTABLE) -main:SHex.MainClass -pkg:gtk-sharp-2.0 -r:Mono.Posix
CSHARP_FLAGS_DEBUG = $(CSHARP_FLAGS) -debug+
#change to the environment compiler
CSHARP_COMPILER = mcs

#if needed, change the executable file
EXECUTABLE = $(MAIN_FILE).exe

#if needed, change the remove command according to your system
RM_CMD = -rm -f $(EXECUTABLE)



all: $(EXECUTABLE)

$(EXECUTABLE): $(CSHARP_SOURCE_FILES)
	@$(CSHARP_COMPILER) $(CSHARP_SOURCE_FILES) $(CSHARP_FLAGS)
	@echo compiling...

run: all
	mono $(EXECUTABLE)

clean:
	@ $(RM_CMD)

remake:
	@ $(MAKE) clean
	@ $(MAKE)

