CXX = g++

CXXFLAGES = -std=c++17 -Wall

TARGET = readfile

OBJ = readfile.o

$(TARGET):	$(OBJ)
	$(CXX)	$(OBJ) -o $(TARGET)

readfile.o: readfile.cpp
	$(CXX) $(CXXFLAGES) -c readfile.cpp

clean:
	rm -f $(OBJ) $(TARGET)
