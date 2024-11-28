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
    Usage #{__FILE__} <files> [--set-title | --standalone-php] | -r | --help
    files:              name of files to be generated
    options:
      --set-title   : to get customized title. if this is stated you can't use
                        --standalone-php or vice-versa
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

# get file_options and filenames
# use those as global variables
$file_options, $files = ARGV.select {|value| value.start_with?('-')}.to_a,
                        ARGV.reject {|value| value.start_with?('-')}

def make_file(filename, template_tag='')
  unless File.exist?(filename) && !File.zero?(filename) then
    file = File.open(filename, 'w')
      if $file_options.include?('--standalone-php') && filename.end_with?('.php') then
        file.write("<?php \n //include __DIR__ . ''")
      else
        file.write template_tag
      end
      file.close
    else puts "No operation carried out."
  end
end

# check to see if I want the script to run test
if !$file_options.include?('-r') then
  for filename in $files do
    title = get_title() \
          if ($file_options.include?('--set-title') && !$file_options.include?('--standalone-php'))
    make_file(filename, html_tags(title))
  end
  exit
end

# overwrite the CLI-ARGV array with only files
# and that to be used by minitest
ARGV = $files

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
    def test_get_title
      assert_equal get_title, 'Test Php'
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
