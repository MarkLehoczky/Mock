# QGXUN0_HFT_2023241.Repository.Template

## Class `BookRepository`

Repository interface for the T model class

**Inherits**: `Repository<Book>`, `IRepository<Book>`



### Constructors

#### `BookRepository(BookDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `BookDbContext` - database context



### Methods

#### `override Read(id: int): Book`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `Book` - element with the id

#### `override Update(element: Book)`

Updates the element with the same id in the database 

**Parameters:**
- element: `Book` - new element with the same id as the old element


---


## Class `AuthorRepository`

Repository interface for the T model class

**Inherits**: `Repository<Author>`, `IRepository<Author>`



### Constructors

#### `AuthorRepository(AuthorDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `AuthorDbContext` - database context



### Methods

#### `override Read(id: int): Author`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `Author` - element with the id

#### `override Update(element: Author)`

Updates the element with the same id in the database 

**Parameters:**
- element: `Author` - new element with the same id as the old element


---


## Class `CollectionRepository`

Repository interface for the T model class

**Inherits**: `Repository<Collection>`, `IRepository<Collection>`



### Constructors

#### `CollectionRepository(CollectionDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `CollectionDbContext` - database context



### Methods

#### `override Read(id: int): Collection`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `Collection` - element with the id

#### `override Update(element: Collection)`

Updates the element with the same id in the database 

**Parameters:**
- element: `Collection` - new element with the same id as the old element


---


## Class `PublisherRepository`

Repository interface for the T model class

**Inherits**: `Repository<Publisher>`, `IRepository<Publisher>`



### Constructors

#### `PublisherRepository(PublisherDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `PublisherDbContext` - database context



### Methods

#### `override Read(id: int): Publisher`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `Publisher` - element with the id

#### `override Update(element: Publisher)`

Updates the element with the same id in the database 

**Parameters:**
- element: `Publisher` - new element with the same id as the old element


---


## Class `BookAuthorConnectorRepository`

Repository interface for the T model class

**Inherits**: `Repository<BookAuthorConnector>`, `IRepository<BookAuthorConnector>`



### Constructors

#### `BookAuthorConnectorRepository(BookAuthorConnectorDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `BookAuthorConnectorDbContext` - database context



### Methods

#### `override Read(id: int): BookAuthorConnector`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `BookAuthorConnector` - element with the id

#### `override Update(element: BookAuthorConnector)`

Updates the element with the same id in the database 

**Parameters:**
- element: `BookAuthorConnector` - new element with the same id as the old element


---


## Class `BookAuthorConnectorRepository`

Repository interface for the T model class

**Inherits**: `Repository<BookCollectionConnector>`, `IRepository<BookCollectionConnector>`



### Constructors

#### `BookAuthorConnectorRepository(BookAuthorConnectorDbContext context)`

Constructor that provides the database context

**Parameters:**
- context: `BookAuthorConnectorDbContext` - database context



### Methods

#### `override Read(id: int): BookCollectionConnector`

Reads an element by the id from the database context

**Parameters:**
- id: `int` - id of the readable element

**Returns:**
- `BookCollectionConnector` - element with the id

#### `override Update(element: BookCollectionConnector)`

Updates the element with the same id in the database 

**Parameters:**
- element: `BookCollectionConnector` - new element with the same id as the old element
