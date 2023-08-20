# GraphQlProject
### Sample Queries
add menu

mutation AddMenu($menu: MenuInputType){
  menuMutation{
    createMenu(menu:$menu){
      id
      name
      imageUrl
    }
  }
}

{
  "menu": {
    "name": "Coffees",
    "imageUrl": "coffee.png"
  }
}

add submenu

mutation AddSubMenu($subMenu: SubMenuInputType){
  subMenuMutation{
    createSubMenu(subMenu:$subMenu){
      id
      name
      imageUrl
      description
      price
      menuId
    }
  }
}

{
  "subMenu": {
    "name": "Latte",
    "imageUrl": "latte.png",
    "price": 17.75,
    "description": "Grande Latte",
    "menuId": 1
  }
}

add reservation
mutation AddReservation($reservation: ReservationInputType) {
  reservationMutation {
    createReservation(reservation: $reservation) {
      id
      name
      totalPeople
      email
      phone
      date
      time
    }
  }
}

{
  "reservation": {
    "name": "Murat",
   "phone": "123123123",
    "email": "benmuratseker@github.com",
    "totalPeople": 2,
    "date": "10th June 2023",
    "time": "6:00PM"
  }
}

queries

query{
  menuQuery{
    menu{
      id
      name
      imageUrl
    }
  }
}

query{
  submenuQuery{
    submenus{
      id
      name
      imageUrl
    }
  }
}

query{
  reservationQuery{
    reservations{
      id
      name
      totalPeople
      email
      phone
      date
      time
    }
  }
}
