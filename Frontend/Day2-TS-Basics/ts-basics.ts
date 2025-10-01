interface IUser {
    id: number,
    name: string,
    email: string
    displayDetails(): void
}

class User implements IUser {
    constructor(public id: number, public name: string, public email: string) { }
    displayDetails(): void {
        console.log(`User: ${this.name}, Email: ${this.email}`);
    }
}

class Admin extends User {
    constructor(
        id: number,
        name: string,
        email: string,
        public privileges: string[]
    ) {
        super(id, name, email);
    }

    displayDetails(): void {
        super.displayDetails();
        console.log(`Privileges: ${this.privileges.join(', ')}`);
    }
}

function getArray<T>(items: T[]): T[] {
    return new Array<T>().concat(items);
}

const users: User[] = [
    new User(1, "Alice", "alice@mail.com"),
    new Admin(2, "Bob", "bob@mail.com", ["Manage Users", "Edit Settings"])
];

users.forEach(u => u.displayDetails());

const numbers = getArray<number>([1, 2, 3, 4]);
console.log(numbers);