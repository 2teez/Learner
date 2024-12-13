#![allow(dead_code, unused_variables)]

#[derive(Debug, Clone)]
struct Person {
    name: String,
    age: u32,
}

impl Person {
    fn make_person(name: &str, age: u32) -> Self {
        Self {
            name: name.to_string(),
            age,
        }
    }
    fn name_change(&mut self, name: &str) -> Self {
        self.name = name.to_string();
        Self {
            name: self.name.clone(),
            age: self.age,
        }
    }

    fn name_change_by_aportioning(&self, name: &str) -> Self {
        Self {
            name: name.to_string(),
            ..*self
        }
    }
}

fn main() {
    let mut p = dbg!(Person::make_person("clojure", 12));
    let mut p2 = p.clone();
    p.name_change("java");
    dbg!(p);
    dbg!(&p2);
    p2 = p2.name_change_by_aportioning("elixir");
    dbg!(p2);
}
