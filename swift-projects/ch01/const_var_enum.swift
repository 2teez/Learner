import Foundation

enum Direction: String {
    case North
    case South
    case East
    case West
}

let direction: Direction = .East

switch direction {
case .North:
    print("North")
case .West:
    print("West")
case .East:
    print("East")
case .South:
    print("South")
}
