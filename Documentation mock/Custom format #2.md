# QGXUN0_HFT_2023241.Repository.Template

## Interface `IRepository<T>`

Repository interface for the T model class

> *Restriction*: T is class

**Type parameters:**
- `T`: model class


### Method `void Create(T element)`

Creates a new element into the database context

**Parameters:**
- element: new element


### Method `T Read(int id)`

Reads an element by the id from the database context

**Parameters:**
- id: id of the readable element

**Returns:**
- element with the id


### Method `void Update(T element)`

Updates the element with the same id in the database 

**Parameters:**
- element: new element with the same id as the old element


### Method `void Delete(int id)`

Deletes an element by the id from the database context

**Parameters:**
- id: id of the deletable element

### Method `IQueryable<T> ReadAll()`

Reads all element from the database context

**Returns:**
- all element


---

## Class `Repository<T>`

Repository for the T model class

> Abstract class
>
> **Inherits**: `IRepository<T>`
>
> *Restriction*: T is class

**Type parameters:**
- `T`: model class


### Property `BookDbContext context`

database context

> protected


### Constructor `Repository(BookDbContext context)`

Constructor that provides the database context


### Method `void Create(T element)`

Creates a new element into the database context

**Parameters:**
- element: new element


### Method `T Read(int id)`

Reads an element by the id from the database context

> abstract method

**Parameters:**
- id: id of the readable element

**Returns:**
- element with the id


### Method `void Update(T element)`

Updates the element with the same id in the database 

> abstract method

**Parameters:**
- element: new element with the same id as the old element


### Method `void Delete(int id)`

Deletes an element by the id from the database context

**Parameters:**
- id: id of the deletable element

### Method `IQueryable<T> ReadAll()`

Reads all element from the database context

**Returns:**
- all element










