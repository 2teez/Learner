import Foundation

var fname: String?
var lname: String = "gosling"

if fname != nil {
    print("\(fname!), \(lname)")
} else {
    fname = "java"
    print("\(fname!), \(lname)")
}

if let name = fname {
    print(name, terminator: "")
}

var names: [String?]? = [String?](repeating: "java", count: 5)
print(names!)
if let severalNames = names {
    print(severalNames)
}
