using ChewAndPhew;

Random random = new();
GumDispenser dispenser = GumDispenser.Instance;

GumDispenserController controller = new GumDispenserController();
// Fylder dispenseren op
controller.AddGum(new Gum("Blåbær"), 14);
controller.AddGum(new Gum("Brombær"), 7);
controller.AddGum(new Gum("Tutti frutti"), 11);
controller.AddGum(new Gum("Appelsin"), 10);
controller.AddGum(new Gum("Jorbdær"), 8);
controller.AddGum(new Gum("Æble"), 5);

dispenser.PrintAmount();
dispenser.DispenseGum();
dispenser.PrintAmount();
