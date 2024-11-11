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

var numbers = [[1, 2], [3, 4], [5, 6]]
print(numbers[2], numbers[1][0])

var nums: [Double] = [Double]()
if let first = nums.first { print("no item in \(first)") }
print(nums.count)
