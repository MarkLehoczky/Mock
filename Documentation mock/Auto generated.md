<a name='assembly'></a>
# Test

## Contents

- [Class1](#T-Test-Namespace1-Class1 'Test.Namespace1.Class1')
  - [#ctor()](#M-Test-Namespace1-Class1-#ctor 'Test.Namespace1.Class1.#ctor')
  - [#ctor(property1,property2,property3,property4,property5)](#M-Test-Namespace1-Class1-#ctor-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32- 'Test.Namespace1.Class1.#ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)')
  - [Property4](#F-Test-Namespace1-Class1-Property4 'Test.Namespace1.Class1.Property4')
  - [Property5](#F-Test-Namespace1-Class1-Property5 'Test.Namespace1.Class1.Property5')
  - [Property1](#P-Test-Namespace1-Class1-Property1 'Test.Namespace1.Class1.Property1')
  - [Property2](#P-Test-Namespace1-Class1-Property2 'Test.Namespace1.Class1.Property2')
  - [Property3](#P-Test-Namespace1-Class1-Property3 'Test.Namespace1.Class1.Property3')
  - [Method1()](#M-Test-Namespace1-Class1-Method1 'Test.Namespace1.Class1.Method1')
  - [Method2()](#M-Test-Namespace1-Class1-Method2 'Test.Namespace1.Class1.Method2')
  - [Method3(parameter1)](#M-Test-Namespace1-Class1-Method3-System-Int32- 'Test.Namespace1.Class1.Method3(System.Int32)')
  - [Method4(parameter2)](#M-Test-Namespace1-Class1-Method4-System-Int32- 'Test.Namespace1.Class1.Method4(System.Int32)')
  - [Method5(parameter3)](#M-Test-Namespace1-Class1-Method5-System-Int32- 'Test.Namespace1.Class1.Method5(System.Int32)')
  - [Method6(parameter4)](#M-Test-Namespace1-Class1-Method6-System-Int32- 'Test.Namespace1.Class1.Method6(System.Int32)')
  - [Method7(parameter5)](#M-Test-Namespace1-Class1-Method7-System-Int32- 'Test.Namespace1.Class1.Method7(System.Int32)')
  - [Method8(parameter6)](#M-Test-Namespace1-Class1-Method8-System-Int32- 'Test.Namespace1.Class1.Method8(System.Int32)')
  - [Method9()](#M-Test-Namespace1-Class1-Method9 'Test.Namespace1.Class1.Method9')
- [Class2](#T-Test-Namespace1-Class2 'Test.Namespace1.Class2')
  - [Method1()](#M-Test-Namespace1-Class2-Method1 'Test.Namespace1.Class2.Method1')
  - [Method2()](#M-Test-Namespace1-Class2-Method2 'Test.Namespace1.Class2.Method2')
  - [Test#Namespace1#Interface1#Method3()](#M-Test-Namespace1-Class2-Test#Namespace1#Interface1#Method3-System-Int32- 'Test.Namespace1.Class2.Test#Namespace1#Interface1#Method3(System.Int32)')
  - [Test#Namespace1#Interface1#Method4()](#M-Test-Namespace1-Class2-Test#Namespace1#Interface1#Method4-System-Int32- 'Test.Namespace1.Class2.Test#Namespace1#Interface1#Method4(System.Int32)')
- [Class3\`1](#T-Test-Namespace2-Class3`1 'Test.Namespace2.Class3`1')
  - [#ctor(property1,property2,property3)](#M-Test-Namespace2-Class3`1-#ctor-`0,`0,System-Int32- 'Test.Namespace2.Class3`1.#ctor(`0,`0,System.Int32)')
  - [Property1](#P-Test-Namespace2-Class3`1-Property1 'Test.Namespace2.Class3`1.Property1')
  - [Property2](#P-Test-Namespace2-Class3`1-Property2 'Test.Namespace2.Class3`1.Property2')
  - [Property3](#P-Test-Namespace2-Class3`1-Property3 'Test.Namespace2.Class3`1.Property3')
- [Class4\`1](#T-Test-Namespace2-Class4`1 'Test.Namespace2.Class4`1')
  - [t](#P-Test-Namespace2-Class4`1-t 'Test.Namespace2.Class4`1.t')
  - [Method1()](#M-Test-Namespace2-Class4`1-Method1 'Test.Namespace2.Class4`1.Method1')
  - [Method2()](#M-Test-Namespace2-Class4`1-Method2 'Test.Namespace2.Class4`1.Method2')
  - [Test#Namespace2#Interface2{T}#Method3()](#M-Test-Namespace2-Class4`1-Test#Namespace2#Interface2{T}#Method3-System-Int32- 'Test.Namespace2.Class4`1.Test#Namespace2#Interface2{T}#Method3(System.Int32)')
  - [Test#Namespace2#Interface2{T}#Method4()](#M-Test-Namespace2-Class4`1-Test#Namespace2#Interface2{T}#Method4-`0- 'Test.Namespace2.Class4`1.Test#Namespace2#Interface2{T}#Method4(`0)')
- [Class5](#T-Test-Namespace2-Class5 'Test.Namespace2.Class5')
  - [Method1()](#M-Test-Namespace2-Class5-Method1 'Test.Namespace2.Class5.Method1')
  - [Method2()](#M-Test-Namespace2-Class5-Method2 'Test.Namespace2.Class5.Method2')
- [Class6](#T-Test-Namespace2-Class6 'Test.Namespace2.Class6')
  - [Method1()](#M-Test-Namespace2-Class6-Method1 'Test.Namespace2.Class6.Method1')
  - [Method2()](#M-Test-Namespace2-Class6-Method2 'Test.Namespace2.Class6.Method2')
- [Class7](#T-Test-Namespace2-Class7 'Test.Namespace2.Class7')
  - [Method1()](#M-Test-Namespace2-Class7-Method1 'Test.Namespace2.Class7.Method1')
- [Interface1](#T-Test-Namespace1-Interface1 'Test.Namespace1.Interface1')
  - [Method1()](#M-Test-Namespace1-Interface1-Method1 'Test.Namespace1.Interface1.Method1')
  - [Method2()](#M-Test-Namespace1-Interface1-Method2 'Test.Namespace1.Interface1.Method2')
  - [Method3(parameter1)](#M-Test-Namespace1-Interface1-Method3-System-Int32- 'Test.Namespace1.Interface1.Method3(System.Int32)')
  - [Method4(parameter2)](#M-Test-Namespace1-Interface1-Method4-System-Int32- 'Test.Namespace1.Interface1.Method4(System.Int32)')
- [Interface2\`1](#T-Test-Namespace2-Interface2`1 'Test.Namespace2.Interface2`1')
  - [Method1()](#M-Test-Namespace2-Interface2`1-Method1 'Test.Namespace2.Interface2`1.Method1')
  - [Method2()](#M-Test-Namespace2-Interface2`1-Method2 'Test.Namespace2.Interface2`1.Method2')
  - [Method3(parameter1)](#M-Test-Namespace2-Interface2`1-Method3-System-Int32- 'Test.Namespace2.Interface2`1.Method3(System.Int32)')
  - [Method4(parameter2)](#M-Test-Namespace2-Interface2`1-Method4-`0- 'Test.Namespace2.Interface2`1.Method4(`0)')

<a name='T-Test-Namespace1-Class1'></a>
## Class1 `type`

##### Namespace

Test.Namespace1

##### Summary

Class example

<a name='M-Test-Namespace1-Class1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty constructor

##### Parameters

This constructor has no parameters.

<a name='M-Test-Namespace1-Class1-#ctor-System-Int32,System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### #ctor(property1,property2,property3,property4,property5) `constructor`

##### Summary

Constructor with properties

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | First property |
| property2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Second property |
| property3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Third property |
| property4 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Fourth property |
| property5 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Fifth property |

<a name='F-Test-Namespace1-Class1-Property4'></a>
### Property4 `constants`

##### Summary

Fourth property

<a name='F-Test-Namespace1-Class1-Property5'></a>
### Property5 `constants`

##### Summary

Fifth property

<a name='P-Test-Namespace1-Class1-Property1'></a>
### Property1 `property`

##### Summary

First property

<a name='P-Test-Namespace1-Class1-Property2'></a>
### Property2 `property`

##### Summary

Second property

<a name='P-Test-Namespace1-Class1-Property3'></a>
### Property3 `property`

##### Summary

Third property

<a name='M-Test-Namespace1-Class1-Method1'></a>
### Method1() `method`

##### Summary

First method

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Class1-Method2'></a>
### Method2() `method`

##### Summary

Second method

##### Returns

ret number

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Class1-Method3-System-Int32-'></a>
### Method3(parameter1) `method`

##### Summary

Third method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='M-Test-Namespace1-Class1-Method4-System-Int32-'></a>
### Method4(parameter2) `method`

##### Summary

Fourth method

##### Returns

ret number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

##### Remarks

remark text

<a name='M-Test-Namespace1-Class1-Method5-System-Int32-'></a>
### Method5(parameter3) `method`

##### Summary

Fifth method

##### Returns

ret number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

##### Example

```
int number = n.Method5(5);
```

<a name='M-Test-Namespace1-Class1-Method6-System-Int32-'></a>
### Method6(parameter4) `method`

##### Summary

Sixth method

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter4 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='M-Test-Namespace1-Class1-Method7-System-Int32-'></a>
### Method7(parameter5) `method`

##### Summary

Seventh method

##### Returns

`true` if true, otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter5 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='M-Test-Namespace1-Class1-Method8-System-Int32-'></a>
### Method8(parameter6) `method`

##### Summary

Eight method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter6 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | exception if something happened |

<a name='M-Test-Namespace1-Class1-Method9'></a>
### Method9() `method`

##### Summary

Ninth method

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace1-Class2'></a>
## Class2 `type`

##### Namespace

Test.Namespace1

##### Summary

Inherited class

<a name='M-Test-Namespace1-Class2-Method1'></a>
### Method1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Class2-Method2'></a>
### Method2() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Class2-Test#Namespace1#Interface1#Method3-System-Int32-'></a>
### Test#Namespace1#Interface1#Method3() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Class2-Test#Namespace1#Interface1#Method4-System-Int32-'></a>
### Test#Namespace1#Interface1#Method4() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace2-Class3`1'></a>
## Class3\`1 `type`

##### Namespace

Test.Namespace2

##### Summary

Generic class

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | generic type |

<a name='M-Test-Namespace2-Class3`1-#ctor-`0,`0,System-Int32-'></a>
### #ctor(property1,property2,property3) `constructor`

##### Summary

Load data

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property1 | [\`0](#T-`0 '`0') | First property |
| property2 | [\`0](#T-`0 '`0') | Second property |
| property3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Third property |

<a name='P-Test-Namespace2-Class3`1-Property1'></a>
### Property1 `property`

##### Summary

First property

<a name='P-Test-Namespace2-Class3`1-Property2'></a>
### Property2 `property`

##### Summary

Second property

<a name='P-Test-Namespace2-Class3`1-Property3'></a>
### Property3 `property`

##### Summary

Third property

<a name='T-Test-Namespace2-Class4`1'></a>
## Class4\`1 `type`

##### Namespace

Test.Namespace2

##### Summary

*Inherit from parent.*

<a name='P-Test-Namespace2-Class4`1-t'></a>
### t `property`

##### Summary

property

<a name='M-Test-Namespace2-Class4`1-Method1'></a>
### Method1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Class4`1-Method2'></a>
### Method2() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Class4`1-Test#Namespace2#Interface2{T}#Method3-System-Int32-'></a>
### Test#Namespace2#Interface2{T}#Method3() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Class4`1-Test#Namespace2#Interface2{T}#Method4-`0-'></a>
### Test#Namespace2#Interface2{T}#Method4() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace2-Class5'></a>
## Class5 `type`

##### Namespace

Test.Namespace2

##### Summary

Another class example

<a name='M-Test-Namespace2-Class5-Method1'></a>
### Method1() `method`

##### Summary

First method

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Class5-Method2'></a>
### Method2() `method`

##### Summary

Second method

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace2-Class6'></a>
## Class6 `type`

##### Namespace

Test.Namespace2

##### Summary

Again a class example

<a name='M-Test-Namespace2-Class6-Method1'></a>
### Method1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Class6-Method2'></a>
### Method2() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace2-Class7'></a>
## Class7 `type`

##### Namespace

Test.Namespace2

##### Summary

The last class example

<a name='M-Test-Namespace2-Class7-Method1'></a>
### Method1() `method`

##### Summary

First method

##### Parameters

This method has no parameters.

<a name='T-Test-Namespace1-Interface1'></a>
## Interface1 `type`

##### Namespace

Test.Namespace1

##### Summary

Interface example

<a name='M-Test-Namespace1-Interface1-Method1'></a>
### Method1() `method`

##### Summary

Interface first method

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Interface1-Method2'></a>
### Method2() `method`

##### Summary

Interface second method

##### Returns

ret number

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace1-Interface1-Method3-System-Int32-'></a>
### Method3(parameter1) `method`

##### Summary

Interface third method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='M-Test-Namespace1-Interface1-Method4-System-Int32-'></a>
### Method4(parameter2) `method`

##### Summary

Interface fourth method

##### Returns

ret number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='T-Test-Namespace2-Interface2`1'></a>
## Interface2\`1 `type`

##### Namespace

Test.Namespace2

##### Summary

Generic interface

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | generic type |

<a name='M-Test-Namespace2-Interface2`1-Method1'></a>
### Method1() `method`

##### Summary

Interface first method

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Interface2`1-Method2'></a>
### Method2() `method`

##### Summary

Interface second method

##### Returns

ret generic

##### Parameters

This method has no parameters.

<a name='M-Test-Namespace2-Interface2`1-Method3-System-Int32-'></a>
### Method3(parameter1) `method`

##### Summary

Interface third method

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number param |

<a name='M-Test-Namespace2-Interface2`1-Method4-`0-'></a>
### Method4(parameter2) `method`

##### Summary

Interface fourth method

##### Returns

ret number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter2 | [\`0](#T-`0 '`0') | generic param |
