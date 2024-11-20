#!/usr/bin/env ruby

module IOS
  def cout(msg='')
    print "#{msg}"
    gets.chomp
  end

  def get_filename(msg)
    filename = cout msg
    until File.exist?(filename) do
        puts "Invalid filename #{filename}."
        filename = cout msg
    end
    filename
  end

  alias get_s cout
  module_function :cout, :get_filename, :get_s

end

if __FILE__ == $0 then
  filename = IOS.get_filename "Enter filename:"
  puts "Filename entered: #{filename}"
end
