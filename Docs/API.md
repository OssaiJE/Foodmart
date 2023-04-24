<div align="center">

### This is a CRUD REST API from scratch using .NET 7

</div>

---

# Overview

We build a CRUD REST API from scratch using .NET 7.
As you would expect, the backend system supports Creating, Reading, Updating and Deleting food.

# API Definition


## Create food

### Create food Request

```js
POST /food
```

```json
{
    "name": "Non-Vegan Sunshine",
    "description": "Non-Vegan everything! Join us for a healthy food..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Create food Response

```js
201 Created
```

```yml
Location: {{host}}/food/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Non-Vegan Sunshine",
    "description": "Non-Vegan everything! Join us for a healthy food..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Get food

### Get food Request

```js
GET /food/{{id}}
```

### Get food Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy food..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salad"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

## Update food

### Update food Request

```js
PUT /food/{{id}}
```

```json
{
    "name": "Vegan Sunshine",
    "description": "Vegan everything! Join us for a healthy food..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Oatmeal",
        "Avocado Toast",
        "Omelette",
        "Salads"
    ],
    "Sweet": [
        "Cookie"
    ]
}
```

### Update food Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/food/{{id}}
```

## Delete food

### Delete food Request

```js
DELETE /food/{{id}}
```

### Delete food Response

```js
204 No Content
```

# VSCode Extensions

- [VSCode Rest Client](https://github.com/Huachao/vscode-restclient) - REST Client allows you to send HTTP request and view the response in Visual Studio Code directly.

- [VSCode Markdown Preview Enhanced](https://github.com/shd101wyy/vscode-markdown-preview-enhanced) - Markdown Preview Enhanced is an extension that provides you with many useful functionalities for previewing markdown files.

