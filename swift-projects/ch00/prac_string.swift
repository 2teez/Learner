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

print(path.count)

let statement = "the quick dog jump over the lazy fox"
for word in statement.split(separator: " ") {
    let startIndex = word.startIndex
    let firstLetter = word[startIndex].uppercased()
    let restLetters = word[word.index(after: startIndex)...].lowercased()
    print(firstLetter + restLetters)
}

enum Planets: String {
    case Mercury, Venus, Earth
}

let place = Planets.Earth
switch place {
case .Earth:
    print(Planets.Earth.rawValue)
default:
    print("no where..")
}

var person = (name: "omit", age: 23, lang: "swift")
print(person.lang)
person.lang = person.lang.uppercased()
print(person)
