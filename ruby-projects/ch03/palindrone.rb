
#!/usr/bin/env ruby

module Palindrone

  def palindrone?
    processed_content == processed_content.reverse
  end

  private
    def processed_content
      self.to_s.downcase.split.join
    end
end
