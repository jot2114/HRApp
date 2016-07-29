$(document)
    .ready(function() {
        $('#resumeForm')
            .validate({
                rules: {
                    Name: {
                        required: true
                    },
                    Address: {
                        required: true
                    },
                    PhoneNumber: {
                        required: true
                    },
                    Email: {
                        required: true
                    },
                    Dob: {
                        required: true
                    },
                    education: {
                        required: true
                    },
                    workHistory: {
                        required: true
                    },
                    JobApplyingFor: {
                        required: true
                    }
                },

                messages: {
                    Name: "Enter your name",
                    Email: "Enter your email",
                    PhoneNumber: "Enter your phone number",

                }

            });
    });