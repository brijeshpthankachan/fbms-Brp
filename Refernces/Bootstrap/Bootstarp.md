




# Bootstrap [ Notes]   
## Table Of Contents



- [Bootstrap [Notes] Table Of Contents](#bootstrap-notes-table-of-contents)
    - [Linking](#linking)
    - [Containers](#containers)
      - [Container Paddding](#container-paddding)
      - [Container Border and Color](#container-border-and-color)
    - [Bootstrap 5 Grid System](#bootstrap-5-grid-system)
      - [Grid Classes](#grid-classes)
    - [Display Headings](#display-headings)
    - [Mark](#mark)
    - [Typographys](#typographys)
    - [Text Colours](#text-colours)
    - [Background Colours](#background-colours)
    - [Tables](#tables)
      - [Basic Table](#basic-table)
    - [Images](#images)
    - [Alerts](#alerts)
    - [Buttons](#buttons)
      - [Button Styles](#button-styles)
      - [Button Outline](#button-outline)
      - [Button Sizes](#button-sizes)
      - [Block Level Buttons](#block-level-buttons)
      - [Active/Disabled Buttons](#activedisabled-buttons)




### Linking

Bootstrap CDN

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet">


***To ensure proper rendering and touch zooming, add the following <meta> tag inside the <head> element:***

```HTML
<meta name="viewport" content="width=device-width, initial-scale=1">
```

```

```

*The `width=device-width` part sets the width of the page to follow the screen-width of the device (which will vary depending on the device).*

*The `initial-scale=1` part sets the initial zoom level when the page is first loaded by the browser.*


### Containers

*uses 2 containing elements to wrap site contents*

1. The `.container` class provides a responsive fixed width container
2. The `.container-fluid` class provides a full width container, spanning the entire width of the viewport

#### Container Paddding

*By default, containers have left and right padding, with `no top or bottom padding.` Therefore, we often use spacing utilities, such as extra padding and margins to make them look even better. For example, `.pt-5 means "add a large top padding"`*

```html
<div class="container pt-5"></div>
```

#### Container Border and Color

```html
<div class="container p-5 my-5 border"></div>

<div class="container p-5 my-5 bg-dark text-white"></div>

<div class="container p-5 my-5 bg-primary text-white"></div>

```


### Bootstrap 5 Grid System

*Bootstrap's grid system is built with `flexbox and allows up to 12 columns` across the page.*

*If you do not want to use all 12 columns individually, you can group the columns together to create wider columns*

*Make sure that the sum adds up to 12 or fewer (it is not required that you use all 12 available columns).*

#### Grid Classes

**The Bootstrap 5 grid system has six classes**

- *`.col-` extra small devices - screen width less than 576px*
- *`.col-sm-` small devices - screen width equal to or greater than 576px*
- *`.col-md-` medium devices - screen width equal to or greater than 768px*
- *`.col-lg-`large devices - screen width equal to or greater than 992px*
- *`.col-xl-` xlarge devices - screen width equal to or greater than 1200px*
- *`.col-xxl-`xxlarge devices - screen width equal to or greater than 1400px*


```html
<div class="row">
  <div class="col-sm-4">.col-sm-4</div>
  <div class="col-sm-8">.col-sm-8</div>
</div>
```

*column with automatic width*
```html
<div class="row">
  <div class="col">.col</div>
  <div class="col">.col</div>
  <div class="col">.col</div>
</div>
```

### Display Headings

*Display heading are used to stand out more than other headings, and there are 6 classes to choose from
`.display-1 to .display-6`*


### Mark

*Bootstrap 5 will style <mark> and `.mark` with a yellow background color and some padding*

### Typographys


```html

.lead                   Makes a paragraph stand out	
.text-start	            Indicates left-aligned text	
.text-break	            Prevents long text from breaking layout	
.text-center	        Indicates center-aligned text	
.text-decoration-none	Removes the underline from a link	
.text-end	            Indicates right-aligned text	
.text-nowrap	        Indicates no wrap text	
.text-lowercase	        Indicates lowercased text	
.text-uppercase	        Indicates uppercased text	
.text-capitalize	    Indicates capitalized text	
.initialism	            Displays the text inside an <abbr> element in a 
                        slightly smaller font size	
.list-unstyled	        Removes the default list-style and left margin 
                        on list items (works on both <ul> and <ol>). This class only 
                        applies to immediate children list items (to remove 
                        the default list-style from any nested lists, apply 
                        this class to any nested lists as well)	

.list-inline	          Places all list items on a single line 
                        (used together with .list-inline-item on each <li> elements)
```

----


### Text Colours 

*Bootstrap 5 has some contextual classes that can be used to provide ***"meaning through colors"****

*The classes for text colors are: 
`.text-muted`, `.text-primary`, `.text-success`, `.text-info`, `.text-warning`, `.text-danger`, .`text-secondary`, `.text-white`, `.text-dark`, `.text-body` (default body color/often black) and `.text-light*`

*You can also add 50% opacity for black or white text with the `.text-black-50` or `.text-white-50` classes*

----

### Background Colours

*The classes for background colors are `.bg-primary`,`.bg-success`, `.bg-info`, `.bg-warning`, `.bg-danger`, `.bg-secondary`, `.bg-dark` and `.bg-light`*



*The `.bg-color` classes above does not work well with text, or atleast then you have to specify a proper `.text-color` class to get the right text color for each background.*

*However, you can use the `.text-bg-color` classes and Bootstrap will automatically handle the appropriate text color for each background color*

----

### Tables

#### Basic Table

*A basic Bootstrap 5 table has a light padding and horizontal dividers.*

*The `.table` class adds basic styling to a table*

```Html

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>

<div class="container mt-3">
  <h2>Basic Table</h2>
  <p>The .table class adds basic styling (light padding and horizontal dividers) to a table:</p>            
  <table class="table">
    <thead>
      <tr>
        <th>Firstname</th>
        <th>Lastname</th>
        <th>Email</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>John</td>
        <td>Doe</td>
        <td>john@example.com</td>
      </tr>
      <tr>
        <td>Mary</td>
        <td>Moe</td>
        <td>mary@example.com</td>
      </tr>
      <tr>
        <td>July</td>
        <td>Dooley</td>
        <td>july@example.com</td>
      </tr>
    </tbody>
  </table>
</div>

</body>
</html>

```

`.table-striped` - *adds zebra-stripes to a table*

`.table-bordered` - *adds borders on all sides of the table and cells*

`.table-hover` - *adds a hover effect (grey background color) on table rows*

`.table-dark` -  *adds a black background to the table*

`.table-borderless` - *removes borders from the table*

`.table-sm` -  *makes the table smaller by cutting cell padding in half*

`.table-responsive` - *adds a scrollbar to the table when needed (when it is too big horizontally)*

---

### Images

---

`.rounded` - *class adds rounded corners to an image*

`.rounded-circle` - *adds shapes the image to a circle*

`.img-thumbnail` - *adds shapes the image to a thumbnail (bordered)*

*Float an image to the left with the `.float-start` class or to the right with `.float-end`*

*Center an image by adding the utility classes `.mx-auto `(margin:auto) and `.d-block (display:block)` to the image*

`.img-fluid` - *The image will then scale nicely to the parent element*


```html
<img src="cinqueterre.jpg" class="rounded" alt="Cinque Terre">

```


### Alerts

*Bootstrap 5 provides an easy way to create predefined alert messages*

`.alert class`, *followed by one*
`.alert-success`, `.alert-info`, `.alert-warning`, `.alert-danger`, `.alert-primary`, `.alert-secondary`, `.alert-light` or .`alert-dark`


```html
<div class="alert alert-success">
  <strong>Success!</strong> Indicates a successful or positive action.
</div>
```

*To close the alert message, add a `.alert-dismissible` class to the alert container. Then add `class="btn-close"` and `data-bs-dismiss="alert"` to a link or a button element (when you click on this the alert box will disappear).*

``` html
<div class="alert alert-success alert-dismissible">
  <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
  <strong>Success!</strong> This alert box could indicate a successful or positive action.
</div>

```
---
### Buttons

#### Button Styles

```Html

<button type="button" class="btn">Basic</button>
<button type="button" class="btn btn-primary">Primary</button>
<button type="button" class="btn btn-secondary">Secondary</button>
<button type="button" class="btn btn-success">Success</button>
<button type="button" class="btn btn-info">Info</button>
<button type="button" class="btn btn-warning">Warning</button>
<button type="button" class="btn btn-danger">Danger</button>
<button type="button" class="btn btn-dark">Dark</button>
<button type="button" class="btn btn-light">Light</button>
<button type="button" class="btn btn-link">Link</button>

```

#### Button Outline

```html

<button type="button" class="btn btn-outline-primary">Primary</button>
<button type="button" class="btn btn-outline-secondary">Secondary</button>
<button type="button" class="btn btn-outline-success">Success</button>
<button type="button" class="btn btn-outline-info">Info</button>
<button type="button" class="btn btn-outline-warning">Warning</button>
<button type="button" class="btn btn-outline-danger">Danger</button>
<button type="button" class="btn btn-outline-dark">Dark</button>
<button type="button" class="btn btn-outline-light text-dark">Light</button>

```

#### Button Sizes

```html

<button type="button" class="btn btn-primary btn-lg">Large</button>
<button type="button" class="btn btn-primary">Default</button>
<button type="button" class="btn btn-primary btn-sm">Small</button>

```
#### Block Level Buttons

*To create a block level button that spans the entire width of the parent element, use the `.d-grid` "helper" class on the parent element*


```html
<div class="d-grid">
  <button type="button" class="btn btn-primary btn-block">Full-Width Button</button>
</div>
```

*If you have many block-level buttons, you can control the space between them with the `.gap-*` class*


#### Active/Disabled Buttons
`A button can be set to an active (appear pressed) or a disabled (unclickable) state`


*The class `.active makes` a button appear pressed, and the disabled attribute makes a button unclickable. Note that <a> elements do not support the disabled attribute and must therefore use the `.disabled` class to make it visually appear disabled.*


`Reference : W3Schools`  
`Notes by` - `brijesh p thankachan`
