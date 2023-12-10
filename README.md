# REPO: bootcamp-dotnet-react-contact-mgmt

# Contact management

Sample application on react to get familiarise with the technology stack.

## Phase 1

### .Net API

_Note: You don’t need to use a database for this. For now, just make sure your api is running. You can use a static list for the time being. If possible, mock the api using wiremock or any other platform you're familiar with._

Create a repository named `Bootcamp.Web.Api` on your profile.

Sample contact object

```
{
    “id” : 1,
    “firstName”: “John”,
    “lastName” : “Doe”,
    “contactType”: Email|Phone,
    “contactAddress” : “”, // either email or phone depending on type
}
```

Implement the following end points

#### `GET` /contacts

    Get all the contacts

#### `GET` /contacts/{id}

    Get the contacts by id

#### `POST` /contacts

    Create new contacts

#### `PUT` /contacts/{id}

    Update contact

#### `DELETE` /contacts/{id}

    Delete contact

### React app

Create a separate repository named `Bootcamp.Web.App` for an WebApp on your GitHub profile.

Create a simple react application to

1. list contacts
1. view/edit contact
1. delete contact

Design you own UI. No need to add css. Main goal is to get to know the react technology.

Use the following routes

#### `/contacts`

    display all the contacts in the table. With delete, and view/edit button.
    Also add a button on top of the page to create new contact.

#### `/contacts/{id}`

    display specific contact. Include delete, cancel and save changes button.

#### `/contacts/new`

    Display's new contact form. Include button cancel and save changes.

## Phase 2

Containerised the asp.net web application and make sure when you run the project it builds and hosts the application into a docker container. Ensure you can hit the breakpoint while running the application through the docker container.

## Phase 3

Use a database to store the contact information and make sure you use entity framework to fetch/add/delete the contact.

Use docker for sql server

## Phase 4

Use oauth2 to secure the api and front end application. You don’t need to set up an identity server for that. you can use the dev identity server. Choose your own oauth2 flow.

## Phase 5

You can enhance your application as you like. Few examples are paging, using css to make it presentable, making responsive to work with mobile devices .etc
