import Foundation

let numbered = 35
var stringOne = "still young at \(numbered)"

print(stringOne)
print("\(stringOne.lowercased()), \(stringOne.uppercased())", separator: "::")
stringOne = "one,to,three"
var stringTwo = stringOne.replacingOccurrences(of: "to", with: "two")
print(stringOne, stringTwo, separator: "::")
