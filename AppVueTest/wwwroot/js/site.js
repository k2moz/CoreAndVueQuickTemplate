// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//alert(6);


// Init F7 Vue Plugin
Framework7.use(Framework7Vue);



// Init Page Components
Vue.component('page-about', {
    template: '#page-about'
});
Vue.component('page-form', {
    template: '#page-form'
});
Vue.component('page-dynamic-routing', {
    template: '#page-dynamic-routing'
});
Vue.component('page-not-found', {
    template: '#page-not-found'
});
Vue.component('year-app', {
    template: '#year-app',
    data: function () {
            return {
                incomesAppData: [

                    {
                        year: 2018,
                        incomes: [
                            {
                                title: "zp",
                                values: [10, 20000, -300000, 400000, 500000, 600000, 700000, 800000, 9, 10, 11, 12],
                                sum: 0,
                            }
                        ],
                        bills: [
                            {
                                title: "sber",
                                values: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12],
                                sum: 0,
                            }
                        ],
                        coasts: [
                            {
                                title: "Rent",
                                values: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12],
                                sum: 0,
                            }
                        ]
                    }

                ],


                context: null,
                title: 'Component Page',
                names: ['John', 'Vladimir', 'Timo'],
            }
        },
        methods: {
            openAlert: function () {
                //var self = this.$app.dialog.alert('Hello world!');

            },

            sum: function () {
                let sum = 0;
                debugger;
                for (let i = 0; i < this.incomesAppData[0].incomes.length; i++) {
                    for (let j = 0; j < this.incomesAppData[0].incomes[i].values.length; j++) {
                        sum += parseInt(this.incomesAppData[0].incomes[i].values[j]);
                    }
                    this.incomesAppData[0].incomes[i].sum = sum;
                    //alert(this.incomesAppData[0].incomes[i].sum)
                    alert(sum)
                    $$('.incomesTotal:nth-child(' + (i + 1) + ')').html(sum);
                }




                // for(let i =0;i<this.incomesAppData[0].bills.values;i++){
                //     sum+=this.incomesAppData[0].bills.values[i];
                // }
                // this.incomesAppData[0].bills.sum = sum;

                // for(let i =0;i<this.incomesAppData[0].coasts.values;i++){
                //     sum+=this.incomesAppData[0].coasts.values[i];
                // }
                // this.incomesAppData[0].coasts.sum = sum;
            }
        },
        on: {
            pageInit: function () {
                //var self = this;

                // do something on page init
                app.data.incomesAppData = this.incomesAppData;
                this.sum();
                $$(document).on('change', '.myTable .table-decimal-input',
                    () => {

                        this.sum();
                    })
                // function(){
                //   alert(self);

                // })
            },
            pageAfterIn: function (event, page) {
                // do something after page gets into the view
                //this.sum();
            },
            pageAfterOut: function () {
                // page has left the view
            },
        }
    
});

// Init App
new Vue({
    el: '#app',
    data: function () {
        return {
            // Framework7 parameters here
            f7params: {
                root: '#app', // App root element
                id: 'io.framework7.testapp', // App bundle ID
                name: 'Framework7', // App name
                theme: 'auto', // Automatic theme detection
                // App routes
                routes: [
                    {
                        path: '/about/',
                        component: 'page-about'
                    },
                    {
                        path: '/form/',
                        component: 'page-form'
                    },
                    {
                        path: '/dynamic-route/blog/:blogId/post/:postId/',
                        component: 'page-dynamic-routing'
                    },
                    {
                        path: '/year-app/',
                        component: 'year-app'
                    },
                    {
                        path: '(.*)',
                        component: 'page-not-found',
                    },
                ],
            },

        }
    },
});