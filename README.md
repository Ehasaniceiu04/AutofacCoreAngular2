#Simple example of Unit of Work and Repository Desgin Pattern in .Net Core and Anglar 2 environment


##Repository Pattern

Martin Flower states in his book "Patterns of Enterprise Application Architecture"

A Repository mediates between the domain and data mapping layers, acting like an in-memory domain object
collection. Client objects construct query specifications declaratively and submit them to Repository for
satisfaction. Objects can be added to and removed from the Repository, as they can from a simple collection
of objects.


Advantages

 1. Duplicates Query Logic
 2. Decouples Application from Persistence
 3. Testablity
 
 
 ##Unit Of Work
 
 Maintains a list of objects affected by a business transaction and coordinates the writing out
of changes and the resolution of concurrency problems.

during sales of inventory system, you fist check availablity of product,  then initiate order finally update the stock. If you commit each operation to db,
eventually system will slow even though database is small. Unit of Work can accomadate whole interrelated database operation.
