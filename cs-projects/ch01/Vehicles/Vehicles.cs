namespace Vehicles;

public interface IPassengerCarrier { }

public interface IHeavyLoadCarrier { }

public abstract class Vehicle { }

public abstract class Car : Vehicle { }

public abstract class Train : Vehicle { }

public class Compact : Car, IPassengerCarrier { }

public class SUV : Car, IPassengerCarrier { }

public class PickUp : Car, IHeavyLoadCarrier { }

public class FourTwoFourDoubleBogey : Train { }

public class PassengerTrain : Train, IPassengerCarrier { }

public class FreightTrain : Train, IHeavyLoadCarrier { }
