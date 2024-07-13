# *ASP.NET MVC Bootcamp*

## Global Content

###  [Day 1:](#day-1) Laying the Foundation with MVC, Razor, and Data Annotations
###  [Day 2:](#day-2) HTTP Request Read-Created-Update
### [Day 3:](#day-3) HTTP Request Delete, Entity Framework
<br>


# Day 1 <a id="day-1"> </a>

<a id="#day-1"> </a><details>

<summary>  Click to see Detail </summary>


### Content :
1. [Key Learnings](#day-1-key-learnings)
2. [Images](#day-1-images)
 
 ## Key Learnings (Day-1)  <a id="day-1-key-learnings"></a>


* MVC (Model-View-Controller)
* Razor Technology
* Working with ASP.NET Framework
* Returning views from controllers
* Data annotation attributes:
  * Required
  * DisplayName
  * MinLength
  * MaxLength
  * EmailAddress


## Images (Day-1) <a id="day-1-images"></a>

!["images/1"](images/1.png) <br> <br>
!["images/2"](images/2.png) <br> <br>
!["images/3"](images/3.png) <br> <br>

</details>

<br><br>

# Day 2 <a id="day-2"> </a>


<details>

<summary>  Click to see Detail </summary>

### Content :

1. [Key Learnings](#day-2-key-learnings)
2. [Images](#day-2-images)
 
 ## Key Learnings (Day-2)  <a id="day-2-key-learnings"></a>


* Learned HTTP Request 
  * [HttpPost]
* Worked on Read, Create, Update processes on objects.



## Images (Day-2) <a id="day-2-images"></a>

!["images/21"](images/21.png) <br> <br>
!["images/22"](images/22.png) <br> <br>
!["images/23"](images/23.png) <br> <br>
!["images/24"](images/24.png) <br> <br>
!["images/25"](images/25.png) <br> <br>

</details>

<br><br>


# Day 3 <a id="day-3"> </a>

<a id="#day-3"> </a><details>

<summary>  Click to see Detail </summary>

### Content :
1. [Key Learnings](#day-3-key-learnings)
2. [Images](#day-3-images)

## Key Learnings (Day-3)  <a id="day-3-key-learnings"></a>


* Worked on Delete process on objects.
* What is Entity Framework? 
* How to use Entity Framework to realize CRUD process.
* DbContext
* Connection String
* How to configure Web.config to connect MsSql Server


 Following configuration is added to **_Web.config_** file in project to connect MSSQL localhost server.

```
<add name="BookDatabase" 
    connectionString="Data Source=.\SQLEXPRESS; Initial Catalog=Books; Integrated Security=true;" 
    providerName="System.Data.SqlClient" />
```

## Images (Day-3) <a id="day-3-images"></a>

!["images/31"](images/31.png) <br> <br>
!["images/32"](images/32.png) <br> <br>
!["images/33"](images/33.png) <br> <br>

</details>