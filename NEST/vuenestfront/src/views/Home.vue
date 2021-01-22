<template>
    <div class="home">
        <h1>Isolation Point List</h1>
        <TableManipulation>
            <p>Enter UDC to find:</p>
            <basic v-if="Advanced">
                <input v-model="SearchVal" placeholder="...">
                <b-button @click='FindMethod'>Submit</b-button>
                <b-button @click='ResetMethod'>Reset</b-button>
            </basic>
            <AdvancedSearch v-else>
                <input v-model="IsolationPoint" placeholder="Islation Point">
                <input v-model="Description" placeholder="Description">
                <input v-model="ParentSystem" placeholder="Parent System">
                <input v-model="IsolationUID" placeholder="Isolation UID">
                <buttons>
                    <b-button @click='FindMethod'>Submit</b-button>
                    <b-button @click='ResetMethod'>Reset</b-button>
                </buttons>
            </AdvancedSearch>
            <p @click="AdvancedToggle">Advanced Search</p>
        </TableManipulation>
        <table>
            <tr>
                <th> UDC</th>
                <th> IsolationUID</th>
                <th> ParentSystem</th>
                <th> IsolationPoint</th>
                <th> SwitchBoardOrCubicle</th>
                <th> Description</th>
                <th> Physical Location</th>
                <th> IsolationCat</th>
                <th> DefaultIso</th>
                <th> FacilityCode</th>
                <th> IsolationType</th>
                <th> EnergyPotential</th>
                <th> Padlockable</th>
                <th> PreferredPadlock</th>
                <th> PreferredLockout</th>
                <th> AlternativeLockout</th>
                <th> IsIsolationPoint</th>
                <th> ValidationPoss</th>
                <th> ValidationMethod</th>
                <th> HighRiskPlant</th>
                <th> Photos</th>
                <th> Comments</th>
                <th> CheckedBy </th>
            </tr>
            <tr v-for="row in IsolationPointList" :key="row.udc">
                <td>{{row.udc}}</td>
                <td>{{row.isolationUID}}</td>
                <td>{{row.parentSystem}}</td>
                <td>{{row.isolationPoint}}</td>
                <td>{{row.switchboardOrCubicle}}</td>
                <td>{{row.description}}</td>
                <td>{{row.physicalLocation}}</td>
                <td>{{row.isolationCat}}</td>
                <td>{{row.defaultIso}}</td>
                <td>{{row.facilityCode}}</td>
                <td>{{row.isolationType}}</td>
                <td>{{row.energyPotential}}</td>
                <td>{{row.padlockable}}</td>
                <td>{{row.preferredPadlock}}</td>
                <td>{{row.preferredLockout}}</td>
                <td>{{row.alternateLockout}}</td>
                <td>{{row.isIsolationPoint}}</td>
                <td>{{row.validationPoss}}</td>
                <td>{{row.validationMethod}}</td>
                <td>{{row.highRiskPlant}}</td>
                <td>{{row.photos}}</td>
                <td>{{row.comments}}</td>
                <td>{{row.checkedBy}}</td>
            </tr>
        </table>
    </div>
</template>

<script>
    import axios from 'axios';
// @ is an alias to /src
    export default {

  name: "Home",
  components: {
        },
        data() {
            return {
                IsolationPointList: "",
                SearchVal: "",
                showSpecifics: false,
                concatenation: null,
                Advanced: true,
                IsolationPoint: "",
                Description: "",
                ParentSystem: "",
                IsolationUID: 0,
                UDC: 0 
            }
        },
        methods: {
            setData(Point) {
                this.IsolationPointList=Point
            },
            AdvancedToggle() {
                if (this.Advanced == true) {
                    this.Advanced = false
                }
                else {
                    this.Advanced=true
                }
            },
            FindMethod() {
                if (this.Advanced == true) {
                    axios
                        .get('https://localhost:44395/api/IsoPoint?UDC=' + this.SearchVal)
                        .then(response => {
                            this.IsolationPointList = response.data
                        })
                }
                else {//This section of the Method will not run yet because UDC is an invalid search param.
                    this.concatenation = "https://localhost:44395/api/IsoPoint?"
                        + "parentsystem=" + this.ParentSystem + "&description=" + this.Description
                        + "&isolationpoint=" + this.IsolationPoint + "&isolationuid=" + this.IsolationUID
                    axios
                        .get(this.concatenation)
                        .then(response => {
                            this.IsolationPointList = response.data
                        })
                }
            },
            ResetMethod() {
                this.concatenation=""
                axios
                    .get('https://localhost:44395/api/IsoPoint/')
                    .then(response => {
                        this.IsolationPointList = response.data
                    })
            }

        },
        beforeRouteEnter(to, from, next) {
            axios
                .get('https://localhost:44395/api/IsoPoint/')
                .then(Point => {
                    next(vm=>vm.setData(Point.data))//VM is a way to call data in a page that has not yet loaded.
                    this.IsolationPointList = Point.data
                })
        }
};
</script>

<style>
    table, th, td {
        border: 1px solid black;
        position:center;
    }
    table {
        margin-bottom:10px;
    }
    TableManipulation {
        text-align:left;
        float:left;
        margin:10px;
    }
    home {
        margin:20px;
    }
</style>
