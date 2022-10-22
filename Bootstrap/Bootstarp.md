## Bootstrap

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

### Container Paddding

*By default, containers have left and right padding, with `no top or bottom padding.` Therefore, we often use spacing utilities, such as extra padding and margins to make them look even better. For example, `.pt-5 means "add a large top padding"`*

```html
<div class="container pt-5"></div>
```

### Container Border and Color

```html
<div class="container p-5 my-5 border"></div>

<div class="container p-5 my-5 bg-dark text-white"></div>

<div class="container p-5 my-5 bg-primary text-white"></div>

```