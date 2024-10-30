import Foundation

let numbered = 35
var stringOne = "still young at \(numbered)"

print(stringOne)
print("\(stringOne.lowercased()), \(stringOne.uppercased())", separator: "::")
stringOne = "one,to,three"
var stringTwo = stringOne.replacingOccurrences(of: "to", with: "two")
print(stringOne, stringTwo, separator: "::")

var path = "one/two/three/four"
let startIndex = path.index(path.startIndex, offsetBy: 4)
let endIndex = path.index(startIndex, offsetBy: 14)

print(path[..<startIndex])
print(path[startIndex..<endIndex])
