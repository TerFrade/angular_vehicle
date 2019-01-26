import { Component, OnInit } from "@angular/core";
import { Vehicle } from "../../models/Vehicle";
@Component({
  selector: "app-vehicles",
  templateUrl: "./vehicles.component.html",
  styleUrls: ["./vehicles.component.css"]
})
export class VehiclesComponent implements OnInit {
  vehicles: Vehicle[];

  constructor() {}

  ngOnInit() {
    this.vehicles = [
      {
        id: 1,
        make: {
          id: 1,
          name: "BMW",
          model: [
            {
              id: 1,
              name: "M1"
            },
            {
              id: 2,
              name: "M2"
            }
          ]
        }
      },
      {
        id: 2,
        make: {
          id: 2,
          name: "Mercedes",
          model: [
            {
              id: 1,
              name: "B1"
            },
            {
              id: 2,
              name: "B2"
            }
          ]
        }
      }
    ];
    console.log(this.vehicles);
  }
}
