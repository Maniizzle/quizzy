<template>
  <div>
    <modal name="register" :clickToClose="false" :adaptive="true">
      <div slot="top-right">
        <button @click="$modal.hide('register')">&times;</button>
      </div>
      <div class="p-4">
        <div class="mb-5">
          <h4>Create an account</h4>
          <p>Fill the form below to create an account</p>
        </div>
        <form class="w-full">
          <div class="flex flex-wrap -mx-3 mb-6">
            <!-- full name field -->
            <div class="w-full md:w-1/2 px-3 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-full-name">Full Name</label>
              <input
                @input="resetValidation('fullname')" 
                v-model="regDetails.fullname"
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-full-name" 
                type="text" 
                v-validate="'required|min:4'"
                data-vv-scope="register"
                name="fullname"
                data-vv-as="full name"  
                placeholder="John Doe"
              >
              <span v-show="errors.has('register.fullname')" class="text-red-500 text-xs italic">
                <!-- <em class="fas fa-info-circle mr-1"></em>  -->
                {{ errors.first('register.fullname') }}
              </span>
            </div>

            <!-- uername field -->
            <div class="w-full md:w-1/2 px-3">
              <label 
                class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2"
                for="grid-user-name"
              >
                Username
              </label>
              <input
                @input="resetValidation('username')" 
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-user-name" 
                v-validate="'required|min:4'"
                data-vv-scope="register"
                name="username"
                data-vv-as="username"  
                type="text" 
                placeholder="Tunmii"
                v-model="regDetails.username"
              >
              <span v-show="errors.has('register.username')" class="text-red-500 text-xs italic">
                <!-- <em class="fas fa-info-circle mr-1"></em>  -->
                {{ errors.first('register.username') }}
              </span>
            </div>
          </div>

          <div class="flex flex-wrap -mx-3 mb-6">
            <!-- email field -->
            <div class="w-full md:w-1/2 px-3 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-email">Email</label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-email" 
                type="email" 
                placeholder="doe@email.com"
                v-model="regDetails.email"
              >
            </div>
            <!-- password field -->
            <div class="w-full px-3 md:w-1/2 mb-6 md:mb-0">
              <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-password">Password</label>
              <input
                class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 mb-3 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
                id="grid-password" 
                type="password" 
                placeholder="******************"
                v-model="regDetails.password"
              >
            </div>
          </div>

          <!-- action button -->
          <div class="flex items-center justify-between">
            <button
              class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
              type="button"
            >
              Sign Up
            </button>
            <a class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800" href="#">
              Forgot Password?
            </a>
          </div>
        </form>
      </div>
    </modal>
  </div>
</template>

<script>
export default {
  data() {
    return {
      regDetails: {
        fullname: '',
        username: '',
        password: '',
        email: ''
      }
    }
  },
  methods: {
    resetValidation(key) {
			let matcher = {
				scope: "register",
				name: key
			};
			this.$validator.reset(matcher);
		},
  }
}
</script>

<style scoped>
  .vm--top-right-slot {
    right: 30px !important;
  }

  .vm--top-right-slot button {
    font-size: 30px !important;
  }
</style>
