/// <binding />
"use strict";
const path = require('path');
const VueLoaderPlugin = require('vue-loader/lib/plugin');

module.exports = {
    entry: "./wwwroot/js/site.js",
    output: {
        filename: './wwwroot/js/dist/bundle.js',
        path: __dirname
        //path: path.join(__dirname+"/wwwroot/js", ""),
        //path: path.resolve(__dirname, 'dist')
    },
    devtool: 'source-map',
    //devServer: {
    //    contentBase: ".",
    //    host: "localhost",
    //    port: 9000
    //},



    module: {
        rules: [
            // {
            //   test: /\.css$/,
            //   use: [
            //     'vue-style-loader',
            //     {
            //       loader: 'css-loader',
            //       options: {
            //         // enable CSS Modules
            //         modules: true,
            //         // customize generated class names
            //         localIdentName: '[local]_[hash:base64:8]'
            //       }
            //     }
            //   ]
            // },
            {
                test: /\.js$/,
                use: ["source-map-loader"],
                enforce: "pre"
            },
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            // это будет применяться к файлам `.js`
            // А ТАКЖЕ к секциям `<script>` внутри файлов `.vue`
            {
                test: /\.js$/,
                loader: 'babel-loader'
            },
            // это будет применяться к файлам `.css`
            // А ТАКЖЕ к секциям `<style>` внутри файлов `.vue`
            {
                test: /\.css$/,
                use: [
                    'vue-style-loader',
                    'css-loader'
                ]
            }
        ]

    },
    plugins: [
        // убедитесь что подключили плагин!
        new VueLoaderPlugin()
    ],
    resolve: {
        alias: {
            'vue$': './wwwroot/lib/vue/vue.js'
            //'vue$': 'C:/SAS/Projects/Vue/scripts/vue.js' // 'vue/dist/vue.common.js' for webpack 1
        },
        extensions: ['*', '.js', '.vue', '.json']
    }
};