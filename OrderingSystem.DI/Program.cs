using OrderingSystem.DI;

Ordering ordering = new Ordering(new SendingSms());

ordering.Order("Product Y is ordered!");