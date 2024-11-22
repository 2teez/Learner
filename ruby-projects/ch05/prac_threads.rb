#!/usr/bin/env ruby

require_relative '../ios'

words = %W/java perl ruby clojure groovy cpp c aig-lang rust/
numbers = (1..10).to_a

wordsthread = Thread.new {
  words.each {|wrd| IOS.pln wrd}
}

numbersthread = Thread.new {
  numbers.each {|number| IOS.pln number}
}

sleep(5)

wordsthread.run
numbersthread.run
wordsthread.join
numbersthread.join
#[wordsthread, numbersthread].each {|t| t.join}
