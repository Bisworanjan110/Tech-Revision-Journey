import { Component } from '@angular/core';

@Component({
  selector: 'app-user-card',
  templateUrl: './user-card.component.html',
  styleUrls: ['./user-card.component.css']
})
export class UserCardComponent {
  users = [
    { id: 1, name: 'Alice Johnson', email: 'alice@example.com', role: 'Admin' },
    { id: 2, name: 'Bob Smith', email: 'bob@example.com', role: 'Resident' },
    { id: 3, name: 'Charlie Davis', email: 'charlie@example.com', role: 'Manager' },
    { id: 4, name: 'Diana Miller', email: 'diana@example.com', role: 'Admin' },
    { id: 5, name: 'Ethan Brown', email: 'ethan@example.com', role: 'Resident' }
  ];

  showDetails(user: any) {
    alert(`User: ${user.name}\nEmail: ${user.email}\nRole: ${user.role}`);
  }

}
