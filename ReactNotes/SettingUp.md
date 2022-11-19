## Create A New React App


```bash
npx create-react-app my-app
cd my-app
npm start
```

**Note**

`npx on the first line is not a typo — it’s a package runner tool that comes with npm 5.2+`



Create React App doesn’t handle backend logic or databases; it just creates a frontend build pipeline,  so you can use it with any backend you want. Under the hood, it uses Babel and webpack, but you don’t need to know anything about them.


#### Creating a Toolchain from Scratch

*A JavaScript build toolchain typically consists of*

- A **package manager**, such as Yarn or npm. It lets you take advantage of a vast ecosystem of third-party packages, and easily install or update them.

- A **bundler**, such as webpack or Parcel. It lets you write modular code and bundle it together into small packages to optimize load time.

- A **compiler** such as Babel. It lets you write modern JavaScript code that still works in older browsers.


