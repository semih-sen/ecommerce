package com.semih.ecommerce.core.utilities.results

class Result {
    private var success: Boolean
    private lateinit var message: String

    constructor(success: Boolean) {
        this.success = success
    }

    constructor(success: Boolean, message: String) {
        this.success = success
        this.message = message
    }

    fun isSuccess(): Boolean {
        return this.success
    }

    fun getMessage():String{
        return this.message
    }
}
