pub trait Vehicle {
    fn change_gear(&mut self, gear: u32);
    fn speed_up(&mut self, speed: u32);
    fn apply_brakes(&mut self, amount: u32);
}

#[derive(Debug)]
pub struct Bike {
    speed: u32,
    gear: u32,
}

impl Bike {
    pub fn new(speed: u32, gear: u32) -> Self {
        Self { speed, gear }
    }
}

#[derive(Debug)]
pub struct Bicycle {
    speed: u32,
    gear: u32,
}

impl Bicycle {
    pub fn new(speed: u32, gear: u32) -> Self {
        Self { speed, gear }
    }
}

impl Vehicle for Bike {
    fn change_gear(&mut self, gear: u32) {
        self.gear = gear;
    }
    fn speed_up(&mut self, speed: u32) {
        self.speed += speed;
    }
    fn apply_brakes(&mut self, amount: u32) {
        self.speed -= amount;
    }
}

impl Vehicle for Bicycle {
    fn change_gear(&mut self, gear: u32) {
        self.gear = gear;
    }
    fn speed_up(&mut self, speed: u32) {
        self.speed += speed;
    }
    fn apply_brakes(&mut self, amount: u32) {
        self.speed -= amount;
    }
}

pub fn print_vehicle_info(vehicle_type: &(impl Vehicle + std::fmt::Debug)) {
    dbg!(vehicle_type);
}
