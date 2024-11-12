#!/usr/bin/env ruby

for i in (1..3) do puts i end
#Or
(1..3).each {|i| p i}

data = 23
$FINAL_NUM = 50
print data && data += 1 while data < $FINAL_NUM
data = 23
puts "\nAnother while loop"
while data < $FINAL_NUM do
  print data
  data += 1
end
puts "\nusing begin/end and while - called while modifiers"
data = 43
begin
  print data
  data += 1
end while data <= $FINAL_NUM
puts "\nusing begin/end and UNTIL"
data = 43
begin
  print data
  data += 1
end until data > $FINAL_NUM
puts "\nusing loop "
data = 43
loop {  #  can use do ... end, but prefer {...}
  break if data > $FINAL_NUM
  print data
  data += 1
}

# instead of using if/elsif/else
# use hash with nums as key in a class
class Day
  DAY_OF_WEEK = {
    mon: "Monday", tue: "Tuesday", wed: "Wednesday",
    thur: "Thursday", thu: "Thursday", fri: "Friday",
    sat: "Saturday", sun: "Sunday", 1 => "Monday"
  }

    class << self
      def ofWeek(day)
        case day
          when Symbol then
            day = day.downcase
            DAY_OF_WEEK[day]
          when Integer then
            DAY_OF_WEEK[day]
          when String then
            day = day[0, 3] if day.length > 3
            day = day.downcase.to_sym
            DAY_OF_WEEK[day]
          else
            p "nothing.."
        end
      end
    end
end

p Day.ofWeek(:Mon)
p Day.ofWeek("Thursday")
p Day.ofWeek(1)
p Day::DAY_OF_WEEK[:wed]
