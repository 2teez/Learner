#!/usr/bin/env ruby

module ArrayExtensions
  def p
    puts case self
    when Range
      self.to_a.join
    else
    puts self.join
    end
  end
end

Array.include(ArrayExtensions)
Range.include(ArrayExtensions)

def helper
  puts <<~"HELP"
    Usage #{__FILE__} <files> [--standalone-php | -r] | --help
    files:              name of files to be generated
    options:
      --standalone-php: to generate standalone php file.
      -r              : to run in file test. Using minitest.
      --help          : to display the help option.
  HELP
end

if ARGV.length == 0 || ARGV[0] == '--help' then
  helper
  exit
end

def get_title(msg='Enter title: ')
  print "#{msg.capitalize}"
  $stdin.gets.chomp.split.each{|w|w.capitalize!}.join(' ')
end

def html_tags(title='Changed Title')
  <<~"HTML_TAG"
  <!DOCTYPE html>
      <html lang="en">
          <head>
              <meta charset="utf-8">
              <title>#{title}</title>
          </head>
          <body>
              <p>
                  <?php
                  ?>
              </p>
          </body>
      </html>
  HTML_TAG
end


def make_file(filename, template_tag='')
  unless File.exist?(filename) && !File.zero?(filename) then
    file = File.open(filename, 'w')
      if ARGV.include?('--standalone-php') && filename.end_with?('.php') then
        file.write("<?php \n //include __DIR__ . ''")
      else
        file.write template_tag
      end
      file.close
    else puts "No operation carried out."
  end
end

# check to see if I want the script to run test
if !ARGV.include?('-r') then
#for filename in ARGV
  #next if filename.start_with?('-')
  title = get_title() \
  if (ARGV.include?('--state-title') && !ARGV.include?('--standalone-php'))

    make_file(ARGV[0], html_tags(title))
  exit
  #end
end

# remove the the option that start with `-`
ARGV = ARGV.join('::').gsub(/-..?/, '').split('::')

if __FILE__ == $0 then
  require 'minitest'
  require 'minitest/autorun'
  require 'fileutils'

  class Test < Minitest::Test
    def setup
      @file = File.open('test.php', 'w')
    end
    def test_or_in_string_extension
      skip
      help=''.or('-h')
      assert_equal help, '-h'
    end
    def test_range_extension
      expected = puts (1..5).to_a.join
      assert_nil expected, (1..5).p
    end
    def test_array_extension
      expected = puts ('a'..'e').to_a.join
      assert_nil expected, ('a'..'e').to_a.p
    end
    def test_make_file
      expected = make_file @file, '<?php?>'
      actual = nil
      assert_nil expected, actual
    end
    def teardown
        FileUtils.rm(@file)
    end
  end
end
